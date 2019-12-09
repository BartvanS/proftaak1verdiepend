#include <SoftwareSerial.h>   //Software Serial Port
#include "motor.h"
#include "ultrasone.h"


void setup()
{
  Serial.begin(9600);
  initMotor(false);
  setUltrasone();
}

void loop()
{
 int cm = getDistance();
 Serial.println(cm);
  forward(255);
}
