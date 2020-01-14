#include <SoftwareSerial.h>   //Software Serial Port
#include "motor.h"
#include "ultrasone.h"
#define RxD 7
#define TxD 6
//#define DEBUG_ENABLED  1
char recvChar;

int cmMiddle;
int cmRight;
int cmLeft;

String snelheidstring;
String inputString = "";
String commandString;// a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
SoftwareSerial blueToothSerial(RxD, TxD);

int red_light_pin = A5;
int green_light_pin = A4;
int blue_light_pin = A3;
int distance = 20;
bool isAutonom = false;
void setup()
{
  setupBlueToothConnection();
  Serial.begin(9600);
  initMotor(true);
  setUltrasone();
  pinMode(RxD, INPUT);
  pinMode(TxD, OUTPUT);
  pinMode(red_light_pin, OUTPUT);
  pinMode(green_light_pin, OUTPUT);
  pinMode(blue_light_pin, OUTPUT);

}

void loop()
{

  if (isAutonom)
  {

    RGB_color(255, 0, 0);

    cmMiddle = getDistance(1);
    cmLeft = getDistance(2);
    cmRight = getDistance(3);
//    Serial.print("Middle: ");
//    Serial.println(cmMiddle);
//    Serial.print("Right: ");
//    Serial.println(cmRight);
//    Serial.print("Left: ");
    //Serial.println(cmLeft);
    forward(255);
    if (cmMiddle < distance) {
      if (cmLeft < cmRight && cmLeft < distance) {
        turnRight(255);
      }
      else if (cmRight < cmLeft && cmRight < distance) {
        turnLeft(255);
      } else if (cmRight < distance && cmLeft < distance) {
        checkSpace(100);
      } else {
        checkSpace(100);
      }
    } else if (cmRight < distance) {
      forwardLeft(255);
    } else if (cmLeft < distance) {
      forwardRight(255);
    }
  } else
  {
    RGB_color(0, 0, 255);

  }

  getCommand();
  receiveInput();
  if (stringComplete)
  {
    Serial.println(inputString);
    stringComplete = false;

    int vooruit = inputVariable(inputString, "forward");

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

    if (commandString == "autonoom") {
      if (inputVariable(inputString, "autonoom") == 1)
      {
        isAutonom = true;
      } else {
      
        isAutonom = false;
        motorOff();
      }
    }
    if (isAutonom == false)
    {
      if (commandString == "forward") {
        forward(inputVariable(inputString, "forward"));
       // blueToothSerial.println("Forward.");
      } else if (commandString == "backward" ) {
        backwards(inputVariable(inputString, "backward"));
       // blueToothSerial.println("Backwards");
      } else if (commandString == "left" ) {
        turnLeftOnSpot(inputVariable(inputString, "left"));
       // blueToothSerial.println("left");
      } else if (commandString == "right" ) {
        turnRightOnSpot(inputVariable(inputString, "right"));
        blueToothSerial.println("right");
      } else if (commandString == "stop") {
        motorOff();
     //  blueToothSerial.println("STOP");
      }
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
void RGB_color(int red_light_value, int green_light_value, int blue_light_value)
{
  analogWrite(red_light_pin, red_light_value);
  analogWrite(green_light_pin, green_light_value);
  analogWrite(blue_light_pin, blue_light_value);
}

void checkSpace(int motorSpeed) {
  motorOff();
  if (cmLeft > cmRight) {
    turnLeftOnSpot(motorSpeed);
  } else if (cmRight > cmLeft) {
    turnRightOnSpot(motorSpeed);
  }
}