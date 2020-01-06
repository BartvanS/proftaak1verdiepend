#include <SoftwareSerial.h>   //Software Serial Port
#include "motor.h"
#include "ultrasone.h"
#define RxD 7
#define TxD 6
//#define DEBUG_ENABLED  1
char recvChar;
int minDistance = 20;
SoftwareSerial blueToothSerial(RxD, TxD);
void setup()
{
  setupBlueToothConnection();
  Serial.begin(9600);
  initMotor(false);
  setUltrasone();
  pinMode(RxD, INPUT);
  pinMode(TxD, OUTPUT);
}

void loop()
{
  receiveInput();
  int  cmMiddle = getDistance(1);
  int cmLeft = getDistance(2);
  forward(255);
  if (cmMiddle < minDistance) {
    doTurn();
  }
}

void doTurn() {
  turnRight(255);
  delay(1000);
  motorOff();
}
void receiveInput() {
  if (Serial.available())
  { //check if there's any data sent from the local serial terminal, you can add the other applications here
    recvChar  = Serial.read();
    blueToothSerial.println("hoi");
  }

  if (blueToothSerial.available())
  { //check if there's any data sent from the remote bluetooth shield
    recvChar = blueToothSerial.read();
    Serial.print(recvChar);
    if (recvChar == 'w') {
      forward(255);
      blueToothSerial.println("Forward.");
    } else if (recvChar == 's' ) {
      backwards(255);
      blueToothSerial.println("Backwards");
    } else if (recvChar == 'a' ) {
      turnLeft(255);
      blueToothSerial.println("left");
    } else if (recvChar == 'd' ) {
      turnRight(255);
      blueToothSerial.println("right");
    } else if(recvChar == 'l') {
      motorOff();
      blueToothSerial.println("STOP");
    }
  }
}
void setupBlueToothConnection()
{
  blueToothSerial.begin(38400);                           // Set BluetoothBee BaudRate to default baud rate 38400
  blueToothSerial.print("\r\n+STWMOD=0\r\n");             // set the bluetooth work in slave mode
  blueToothSerial.print("\r\n+STNA=JOE_BOT\r\n");    // set the bluetooth name as "SeeedBTSlave"
  blueToothSerial.print("\r\n+STOAUT=1\r\n");             // Permit Paired device to connect me
  blueToothSerial.print("\r\n+STAUTO=0\r\n");             // Auto-connection should be forbidden here
  delay(2000);                                            // This delay is required.
  blueToothSerial.print("\r\n+INQ=1\r\n");                // make the slave bluetooth inquirable
  Serial.println("The slave bluetooth is inquirable!");
  delay(2000);                                            // This delay is required.
  blueToothSerial.flush();
}
