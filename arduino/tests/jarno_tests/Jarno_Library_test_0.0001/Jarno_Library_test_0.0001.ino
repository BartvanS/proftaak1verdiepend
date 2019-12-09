#include "motor.h"

void setup() {
  initMotor(true);
}

void loop() {
  forward(255);
  delay(1000);
  initMotor(false);
  forward(200);
  delay(1000);
  initMotor(true);
  
}
