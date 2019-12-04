//
int trig = 12;
int echo = 3;
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

bool detected = false;
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
  digitalWrite(trig, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig, LOW);
  lecture_echo = pulseIn(echo, HIGH);
  cm = lecture_echo / 58;
  Serial.println(cm);

  //rijd naar voren
  //  vooruit();

  //check afstand
  if (cm < 20)
  {
    vooruit();
    //ga naar links en kijk er plek is
    //if (plek) rijd naar voren
    //else kijk rechts
    // if(rechts plek vrij) rijd naar voren
    // elserijd een stuk naar achteren en rijd naar links

    //gebaseerd op de laatste richting krijgt de andere richting prioriteit bij de volgende stop.
    //dus als hij naar links ging en ging rijden dan zou hij de eerstvolgende stop eerst rechts kijken of er plek is
  }
  else
  {
    achteruit();
    digitalWrite(led, LOW);
  }

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
