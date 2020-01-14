#include <SoftwareSerial.h>   //Software Serial Port
#include "motor.h"
#include "ultrasone.h"
#define RxD 7
#define TxD 6
//#define DEBUG_ENABLED  1
char recvChar;


String snelheidstring;
String inputString = "";
String commandString;// a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
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
 getCommand();
  receiveInput();
  if(stringComplete)
  {
    stringComplete = false;

   int vooruit = inputVariable(inputString, "forward");
    Serial.println(vooruit);
   inputString = "";
  }
}
void receiveInput() {


  if (blueToothSerial.available())
  { //check if there's any data sent from the remote bluetooth shield
    recvChar = blueToothSerial.read();
  inputString += recvChar;
  if (recvChar == '%') {
     stringComplete = true;
    }
    
    if (commandString == "forward") {
      forward(inputVariable(inputString, "forward"));
      blueToothSerial.println("Forward.");
    } else if (commandString == "backward" ) {
      backwards(inputVariable(inputString, "backward"));
      blueToothSerial.println("Backwards");
    } else if (commandString == "left" ) {
      turnLeft(inputVariable(inputString, "left"));
      blueToothSerial.println("left");
    } else if (commandString == "right" ) {
      turnRight(inputVariable(inputString, "right"));
      blueToothSerial.println("right");
    } else if(commandString == "stop") {
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
