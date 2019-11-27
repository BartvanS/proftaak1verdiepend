int enA = 11;
int in1 = 7;
int in2 = 6;
int enB = 9
;
int in3 = 5;
int in4 = 4;
void setup()
{
  // set all the motor control pins to outputs
  pinMode(enA, OUTPUT);
  pinMode(enB, OUTPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  pinMode(in3, OUTPUT);
  pinMode(in4, OUTPUT);
}
void achteruit(){
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
  digitalWrite(in3, HIGH);
  digitalWrite(in4, LOW);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void vooruit(){
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void links(){
  digitalWrite(in1, LOW); // eerste 2 zijn links 2de rechts
  digitalWrite(in2, HIGH);
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void rechts(){
  digitalWrite(in1, HIGH); // eerste 2 zijn links 2de rechts
  digitalWrite(in2, LOW);
  digitalWrite(in3, HIGH);
  digitalWrite(in4, LOW);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void uit(){
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
  digitalWrite(in3, LOW);
  digitalWrite(in4, LOW);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void loop(){
  links();
}
