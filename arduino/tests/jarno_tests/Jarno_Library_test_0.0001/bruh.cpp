#include "Arduino.h"
#include "bruh.h"

//void setupPins(int enA, int enB, int in1, int in2, int in3, int in4){
//  pinMode(enA, OUTPUT);
//  pinMode(enB, OUTPUT);
//  pinMode(in1, OUTPUT);
//  pinMode(in2, OUTPUT);
//  pinMode(in3, OUTPUT);
//  pinMode(in4, OUTPUT);
//}

void setupLeds(int ledPin1, int ledPin2){
  pinMode(ledPin1, OUTPUT);
  pinMode(ledPin2, OUTPUT);
}

void ledKnipper(int ledPin1, int ledPin2, int delaytje){
  digitalWrite(ledPin1, HIGH);
  digitalWrite(ledPin2, LOW);
  delay(delaytje);
  digitalWrite(ledPin1, LOW);
  digitalWrite(ledPin2, HIGH);
  delay(delaytje);
}
//
//void vooruit(int snelheid){
//  
//}
