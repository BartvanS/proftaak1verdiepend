
//uninterupted delay
unsigned long previousMillis = 0;
bool goLeft = 0;
int interval = 2000;


// ultrasone sensor
int trig = 12;
int echo = 9;
long lecture_echo;
long cm;
//motor shield
int enA = 10;
int in1 = 7;
int in2 = 6;
int enB = 11;
int in3 = 5;
int in4 = 4;
//test led
int led = 8;
//afgesproken afstand
int setDistance = 20;
void setup()
{
  pinMode(enA, OUTPUT);
  pinMode(enB, OUTPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  pinMode(in3, OUTPUT);
  pinMode(in4, OUTPUT);
  //ultrasone
  pinMode(trig, OUTPUT);
  digitalWrite(trig, LOW);
  pinMode(echo, INPUT);
  Serial.begin(9600);
  //led output
  pinMode(led, OUTPUT);
}
void loop()
{
  unsigned long currentMillis = millis();
  digitalWrite(trig, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig, LOW);
  lecture_echo = pulseIn(echo, HIGH);
  cm = lecture_echo / 58;

  //rijd naar voren
  vooruit();

  //check afstand
  if (cm < setDistance)
  {

    if (goLeft < 5) {
      links();
    } else {
      rechts();
    }
    if (currentMillis - previousMillis >= interval) {
      previousMillis = currentMillis;
      goLeft = goLeft + 1;

      //      if (!isFree(cm)) {
      //        rechts();
      //        delay(3000);
      //      }

    }
  }
}
bool isFree(int cm) {
  if (cm > setDistance) {
    Serial.println("Plek is vrij");
    return true;
  }
  return false;
}






void vooruit()
{
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  digitalWrite(in3, HIGH);
  digitalWrite(in4, LOW);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void achteruit()
{
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void links()
{
  digitalWrite(in1, HIGH); // eerste 2 zijn links 2de rechts
  digitalWrite(in2, LOW);
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void rechts()
{
  digitalWrite(in1, LOW); // eerste 2 zijn links 2de rechts
  digitalWrite(in2, HIGH);
  digitalWrite(in3, HIGH);
  digitalWrite(in4, LOW);
  analogWrite(enA, 255);
  analogWrite(enB, 255);
}

void uit()
{
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
  digitalWrite(in3, LOW);
  digitalWrite(in4, LOW);
  analogWrite(enA, 0);
  analogWrite(enB, 0);
}
