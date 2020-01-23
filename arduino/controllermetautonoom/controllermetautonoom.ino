#include <SoftwareSerial.h>   //Software Serial Port
#include "motor.h"
#include "ultrasone.h"
#include <Wire.h>
#include <MPU6050.h>
#define RxD 7
#define TxD 6
//#define DEBUG_ENABLED  1
char recvChar;

int cmMiddle;
int cmRight;
int cmLeft;
float yaw = 0;

String snelheidstring;
String inputString = "";
String commandString;// a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
SoftwareSerial blueToothSerial(RxD, TxD);

int red_light_pin = A5;
int green_light_pin = A4;
int blue_light_pin = A3;
int distance = 30;
bool isAutonom = false;
void setup()
{ 
  compasssetup();
  setupBlueToothConnection();
  Serial.begin(115200);
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
  getyaw();
  blinkDisco();
   Serial.println(yaw);
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
    blueToothSerial.print("#forward:");
    blueToothSerial.print(255);
    blueToothSerial.print("%");
    if (cmMiddle < distance) {
      if (cmLeft < cmRight && cmLeft < distance) {
        turnRight(255);
        blueToothSerial.print("#turnRight:");
        blueToothSerial.print(255);
        blueToothSerial.print("%");
      }
      else if (cmRight < cmLeft && cmRight < distance) {
        turnLeft(255);
        blueToothSerial.print("#turnLeft:");
        blueToothSerial.print(255);
        blueToothSerial.print("%");
      } else if (cmRight < distance && cmLeft < distance) {
        checkSpace(100);
        blueToothSerial.print("#turnRight:");
        blueToothSerial.print(255);
        blueToothSerial.print("%");
      } else {
        checkSpace(100);
        blueToothSerial.print("#checkSpace:");
        blueToothSerial.print(255);
        blueToothSerial.print("%");
      }
    } else if (cmRight < distance) {
      forwardLeft(255);
      blueToothSerial.print("#turnForwardLeft:");
      blueToothSerial.print(255);
      blueToothSerial.print("%");
    } else if (cmLeft < distance) {
      forwardRight(255);
      blueToothSerial.print("#turnForwardRight:");
      blueToothSerial.print(255);
      blueToothSerial.print("%");
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

      } else if (commandString == "backward" ) {
        backwards(inputVariable(inputString, "backward"));

      } else if (commandString == "left" ) {
        turnLeftOnSpot(inputVariable(inputString, "left"));

      } else if (commandString == "right" ) {
        turnRightOnSpot(inputVariable(inputString, "right"));

      } else if (commandString == "stop") {
        motorOff();

      } else if (commandString == "softleft") {
        forwardLeft(inputVariable(inputString, "softleft"));

      } else if (commandString == "softright") {
        forwardRight(inputVariable(inputString, "softright"));

      } else if (commandString == "backleft") {
        backwardLeft(inputVariable(inputString, "backleft"));

      } else if (commandString == "backright") {
        backwardRight(inputVariable(inputString, "backright"));
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
