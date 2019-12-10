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

  unsigned long currentMillis = millis();
  int cm = getDistance();
  Serial.println(cm);
  int count = 0;
  forward(255);

  int goLeft = false;
  if (cm < minDistance) {
     goLeft = true;
//    if (currentMillis - previousMillis >= interval) {
//      // save the last time you blinked the LED
//      previousMillis = currentMillis;
   ////////   //ik heb geen idee hoe ik de auto voor een paar seconden met een uninterupted delay kan aansturen.
//    }
    if (goLeft == true) {
      turnLeft(255);
    }
    delay(3000);
  }

}
