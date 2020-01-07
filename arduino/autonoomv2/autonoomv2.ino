#include "motor.h"
#include "ultrasone.h"

int leftDistance;
int rightDistance;

unsigned long previousMillis = 0;   
const long delays = 3000;  
void setup() {
  initMotor(true);
  setUltrasone();
}

void lookFreeSpace(){
   unsigned long currentMillis = millis();
 if (currentMillis - previousMillis >= delays) {
    previousMillis = currentMillis;
 }else
 {
  turnLeft(255);
 }
  motorOff();
  leftDistance = getDistance();
  
   if (currentMillis - previousMillis >= delays * 2) {
    previousMillis = currentMillis;
 }else{
  turnRight(255);
 }
 
  motorOff();
  rightDistance = getDistance();
}

void loop() {
int cm = getDistance();
forward(150);

if(cm <= 20){
  lookFreeSpace();
  if(rightDistance <= 20 && leftDistance <= 20){
    backwards(255);
    delay(500);
  } else if(leftDistance > rightDistance){
    if(leftDistance < 20){
      backwards(150);
      delay(300);
      lookFreeSpace();
    } else {
      turnLeft(255);
      delay(750);
      forward(150);
    }
  } else if(leftDistance == rightDistance){
    backwards(255);
    delay (250);
    lookFreeSpace();
  } else if(rightDistance > leftDistance){
    
  }
  
}
}
