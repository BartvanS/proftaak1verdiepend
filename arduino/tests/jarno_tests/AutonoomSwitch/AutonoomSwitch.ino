int red_light_pin= A5;
int green_light_pin = A4;
int blue_light_pin = A3;
bool ledColor= false;
bool autonoomSwitch = false;
char recvChar;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(red_light_pin, OUTPUT);
  pinMode(green_light_pin, OUTPUT);
  pinMode(blue_light_pin, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  while(autonoomSwitch == false){
    RGB_color(255,0,0);
    receiveInput();
  }
  while(autonoomSwitch == true){
    RGB_color(0,0,255);
    receiveInput();
  }
  
}

void RGB_color(int red_light_value, int green_light_value, int blue_light_value)
 {
  analogWrite(red_light_pin, red_light_value);
  analogWrite(green_light_pin, green_light_value);
  analogWrite(blue_light_pin, blue_light_value);
}

void receiveInput() {

  if (Serial.available())
  { //check if there's any data sent from the remote bluetooth shield
    recvChar = Serial.read();
    Serial.print(recvChar);
    if (recvChar == 'o') {
      autonoomSwitch = true;
    } else if (recvChar == 'v' ) {
      autonoomSwitch = false;
    }
    }
  }
