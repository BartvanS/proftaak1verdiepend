#include <SoftwareSerial.h>   //Software Serial Port
#define RxD 7
#define TxD 6

#define DEBUG_ENABLED  1

SoftwareSerial blueToothSerial(RxD, TxD);
int enA = 10;
int in1 = 9;
int in2 = 8;
int enB = 5;
int in3 = 4;
int in4 = 3;  

int snelheid = 255;
void setup()
{
  Serial.begin(9600);
    
  pinMode(enA, OUTPUT);
  pinMode(enB, OUTPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  pinMode(in3, OUTPUT);
  pinMode(in4, OUTPUT);
  
  pinMode(RxD, INPUT);
  pinMode(TxD, OUTPUT);
  setupBlueToothConnection();


}

void loop()
{

  char recvChar;
  while (1)
  {
    if (blueToothSerial.available())
    { //check if there's any data sent from the remote bluetooth shield
      recvChar = blueToothSerial.read();
      Serial.print(recvChar);
      if (recvChar == 'w') {
          vooruit();
        Serial.println("lampje aan.");
      }else if (recvChar == 's' ){
        achteruit();
      }else if (recvChar == 'a' ){
        links();
      }else if (recvChar == 'd' ){
        rechts();
      }else if (recvChar == 'p' ){
      
        }else if (recvChar == 'o' ){
       
        }else{
        uit();
      }
    }
    if (Serial.available())
    { //check if there's any data sent from the local serial terminal, you can add the other applications here
      recvChar  = Serial.read();
      blueToothSerial.print(recvChar);
    }
  }
}

void setupBlueToothConnection()
{
  blueToothSerial.begin(38400);                           // Set BluetoothBee BaudRate to default baud rate 38400
  blueToothSerial.print("\r\n+STWMOD=0\r\n");             // set the bluetooth work in slave mode
  blueToothSerial.print("\r\n+STNA=SeeedBTSlave2\r\n");    // set the bluetooth name as "SeeedBTSlave"
  blueToothSerial.print("\r\n+STOAUT=1\r\n");             // Permit Paired device to connect me
  blueToothSerial.print("\r\n+STAUTO=0\r\n");             // Auto-connection should be forbidden here
  delay(2000);                                            // This delay is required.
  blueToothSerial.print("\r\n+INQ=1\r\n");                // make the slave bluetooth inquirable
  Serial.println("The slave bluetooth is inquirable!");
  delay(2000);                                            // This delay is required.
  blueToothSerial.flush();
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
  analogWrite(enA, snelheid);
  analogWrite(enB, snelheid);
}

void links(){
  digitalWrite(in1, LOW); // eerste 2 zijn links 2de rechts
  digitalWrite(in2, HIGH);
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  analogWrite(enA, snelheid);
  analogWrite(enB, snelheid);
}

void rechts(){
  digitalWrite(in1, HIGH); // eerste 2 zijn links 2de rechts
  digitalWrite(in2, LOW);
  digitalWrite(in3, HIGH);
  digitalWrite(in4, LOW);
  analogWrite(enA, snelheid);
  analogWrite(enB, snelheid);
}

void uit(){
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW); 
  digitalWrite(in3, LOW);
  digitalWrite(in4, LOW);
  analogWrite(enA, 0);
  analogWrite(enB, 0);
}
