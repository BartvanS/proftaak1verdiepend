#include "Arduino.h"
#include "ultrasone.h"

// ultrasone sensor middle 1
int trigMiddle = 12;
#define echoMiddle A0
// ultrasone sensor left 2
int trigLeft = 2;
#define echoLeft A1
// ultrasone sensor right 3
int trigRight = 4;
#define echoRight A2
long lecture_echo;
long cm;

void setUltrasone() {
  //middle
  pinMode(trigMiddle, OUTPUT);
  digitalWrite(trigMiddle, LOW);
  pinMode(echoMiddle, INPUT);
  //left
  pinMode(trigLeft, OUTPUT);
  digitalWrite(trigLeft, LOW);
  pinMode(echoLeft, INPUT);
  //right
  pinMode(trigRight, OUTPUT);
  digitalWrite(trigRight, LOW);
  pinMode(echoRight, INPUT);
}

int getDistance(int servoName) {
  int trigger = trigMiddle;
  int echo = echoMiddle;
  switch (servoName) {
    case 1:
      trigger = trigMiddle;
      echo = echoMiddle;
      break;
    case 2:
      trigger = trigLeft;
      echo = echoLeft;
      break;
    case 3:
      trigger = trigRight;
      echo = echoRight;
      break;
  }
  digitalWrite(trigger, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigger, LOW);
  lecture_echo = pulseIn(echo, HIGH);
  cm = lecture_echo / 58;
  return cm;
}
