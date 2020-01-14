#include "ultrasone.h"
int cmMiddle;
int cmRight;
int cmLeft;

int leftDistance;
int rightDistance;
int distance = 10;

int enA = 10;
int in1 = 9;
int in2 = 8;
int enB = 11;
int in3 = 5;
int in4 = 4;

int Vrechts = 0;
int error = 0;
int Kp = 5;

unsigned long previousMillis = 0;        // will store last time LED was updated

// constants won't change:
const long interval = 10;
void setup() {
  setUltrasone();
  Serial.begin(9600);
  in1 = 8;
  in2 = 9;
  in3 = 4;
  in4 = 5;
  pinMode(enA, OUTPUT);
  pinMode(enB, OUTPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  pinMode(in3, OUTPUT);
  pinMode(in4, OUTPUT);
}



void loop() {
  cmLeft = getDistance(2);
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  analogWrite(enA, Vrechts);
  analogWrite(enB, 125);

  unsigned long currentMillis = millis();

  if (currentMillis - previousMillis >= interval) {
    previousMillis = currentMillis;

    error = distance - cmLeft;
    Vrechts = 125 - error * Kp;
  }
}
