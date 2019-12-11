#include <SoftwareSerial.h>   //Software Serial Port
#include "motor.h"
#include "ultrasone.h"

//uninterupted delay
unsigned long previousMillis = 0;
int interval = 2000;

int minDistance = 20;

void setup()
{
  Serial.begin(9600);
  initMotor(false);
  setUltrasone();
}

void loop()
{
  //        if (currentMillis - previousMillis >= interval) {
  //          // save the last time you blinked the LED
  //          previousMillis = currentMillis;
  //       //ik heb geen idee hoe ik de auto voor een paar seconden met een uninterupted delay kan aansturen.
  //        }
  unsigned long currentMillis = millis();
  int cm = getDistance();
  Serial.println(cm);
  int count = 0;
  forward(255);
  scanSide("left");
  //  if(!scanSide("left")){
  //    turnRight(255);
  //    delay(1500);
  //    scanSide("right");
  //  }
}

bool scanSide(String side) {
  int cm = getDistance();
  int maxTurns = 0;
  while (cm < minDistance) {
    maxTurns += 1;
    cm = getDistance();
    if (cm > minDistance) {
      return true;
    }
    if (side == "left") {
      turnLeft(255);
    } 
    delay(500);
  }
  return false;
}


//bool scanSide(String side) {
//  int cm = getDistance();
//  int maxTurns = 0;
//  while (cm < minDistance && maxTurns < 3) {
//    maxTurns += 1;
//    cm = getDistance();
//    if (cm > minDistance) {
//      return true;
//    }
//    if (side == "left") {
//      turnLeft(255);
//    } else {
//      turnRight(255);
//    }
//    delay(500);
//  }
//  return false;
//}
