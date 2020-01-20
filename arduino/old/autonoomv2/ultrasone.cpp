#include "Arduino.h"
#include "ultrasone.h"

// ultrasone sensor
int trig = 12;
int echo = 9;
long lecture_echo;
long cm;

void setUltrasone() {
  pinMode(trig, OUTPUT);
  digitalWrite(trig, LOW);
  pinMode(echo, INPUT);
}

int getDistance() {
  digitalWrite(trig, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig, LOW);
  lecture_echo = pulseIn(echo, HIGH);
  cm = lecture_echo / 58;
  return cm;
}
