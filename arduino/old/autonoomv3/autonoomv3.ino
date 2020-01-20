#include "motor.h"
#include "ultrasone.h"
int cmMiddle;
int cmRight;
int cmLeft;

int leftDistance;
int rightDistance;
int distance = 20;

void setup() {
  initMotor(true);
  setUltrasone();
  Serial.begin(9600);
}



void loop() {
  cmMiddle = getDistance(1);
  cmLeft = getDistance(2);
  cmRight = getDistance(3);
  Serial.print("Middle: ");
  Serial.println(cmMiddle);
  Serial.print("Right: ");
  Serial.println(cmRight);
  Serial.print("Left: ");
  Serial.println(cmLeft);
//  forward(255);
//  if (cmMiddle < distance) {
//    if (cmLeft < cmRight && cmLeft < distance) {
//      turnRight(255);
//    }
//    else if (cmRight < cmLeft && cmRight < distance) {
//      turnLeft(255);
//    } else if (cmRight < distance && cmLeft < distance) {
//      checkSpace(100);
//    } else {
//      checkSpace(100);
//    }
//  } else if (cmRight < distance) {
//    forwardLeft(255);
//  } else if (cmLeft < distance) {
//    forwardRight(255);
//  }
}
//
//void checkSpace(int motorSpeed) {
//  motorOff();
//  if (cmLeft > cmRight) {
//    turnLeftOnSpot(motorSpeed);
//  } else if (cmRight > cmLeft) {
//    turnRightOnSpot(motorSpeed);
//  }
//}
