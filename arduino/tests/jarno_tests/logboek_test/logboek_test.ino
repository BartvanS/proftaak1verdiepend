int waarde = 8;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.print("#forward:");
  Serial.print(waarde);
  Serial.println("%");
  delay(100);
  Serial.print("#backwards:");
  Serial.print(waarde);
  Serial.println("%");
  delay(500);
}
