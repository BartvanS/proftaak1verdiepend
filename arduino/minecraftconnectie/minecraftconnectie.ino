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
  receiveInput();
}
void receiveInput() {
  if (blueToothSerial.available()) {
    recvChar = blueToothSerial.read();
    inputString = recvChar;
    Serial.println(inputString);

    if (inputString == "f") {
      RGB_color(255, 0, 0);
      forward(255);
    } else if (inputString == "b") {
      backwards(255);
      RGB_color(0, 255, 0);
    } else if (inputString == "l") {
      RGB_color(0, 0, 255);
      turnLeft(255);
    } else if (inputString == "r") {
      RGB_color(255, 0, 255);
      turnRight(255);
    } else if (inputString == "s") {
      RGB_color(0, 0, 0);
      motorOff();
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
