// ultrasone sensor1
int trig1 = 12;
int echo1 = 9;
long lecture_echo1;
long cm1;

// ultrasone sensor2
int trig2 = 8;
#define echo2 A0
long lecture_echo2;
long cm2;

void setup() {
  Serial.begin(9600);
  pinMode(trig1, OUTPUT);
  digitalWrite(trig1, LOW);
  pinMode(echo1, INPUT);
  pinMode(trig2, OUTPUT);
  digitalWrite(trig2, LOW);
  pinMode(echo2, INPUT);
}

void loop() {
  Serial.println(getDistance1());  
  Serial.println(getDistance2());
}

int getDistance1() {
  digitalWrite(trig1, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig1, LOW);
  lecture_echo1 = pulseIn(echo1, HIGH);
  cm1 = lecture_echo1 / 58;
  return cm1;
}

int getDistance2() {
  digitalWrite(trig2, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig2, LOW);
  lecture_echo2 = pulseIn(echo2, HIGH);
  cm2 = lecture_echo2 / 58;
  return cm2;
}
