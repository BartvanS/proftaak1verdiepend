
String snelheidstring;
String inputString = "";
String commandString;// a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
int led1Pin = 8;
int led2Pin = 9;
int led3Pin = 21;


boolean isConnected = false;

void setup() {

  Serial.begin(9600);
  pinMode(led1Pin, OUTPUT);
  pinMode(led2Pin, OUTPUT);
  pinMode(led3Pin, OUTPUT);

}

void loop() {

  if (stringComplete)
  {
    stringComplete = false;
    getCommand();


    if (commandString.equals("STOP"))
    {

    }
    else if (commandString.equals("TEXT"))
    {

    }
    if (commandString.equals("forward"))
    {
      int dblpointIndex = inputString.indexOf(':');
      String snelheidstring = inputString.substring(dblpointIndex + 1, inputString.length() - 2);

      if (isValidNumber(snelheidstring))
      {
        if (waardeSnelheid() <= 255 && waardeSnelheid() >= 0)
        {
          vooruit(waardeSnelheid());
        } else
        {
          
        }
      } else {
        
      }
    }


    else if (commandString.equals("back"))
    {
    int dblpointIndex2 = inputString.indexOf(':');
      String snelheidstring = inputString.substring(dblpointIndex2 + 1, inputString.length() - 2);

      if (isValidNumber(snelheidstring))
      {
        if (waardeSnelheid() <= 255 && waardeSnelheid() >= 0)
        {
          achteruit(waardeSnelheid());
        } else
        {
          
        }
      } else {
        
      }
    }

    inputString = "";
  }
}







void getCommand()
{
  if (inputString.length() > 0)
  {
    int dblpointIndex = inputString.indexOf(':');
    commandString = inputString.substring(0, dblpointIndex);

    Serial.print(commandString);

  }
}
int waardeSnelheid()
{
  int dblpointIndex = inputString.indexOf(':');
  int snelheid = inputString.substring(dblpointIndex + 1, inputString.length() - 1).toInt();
  return snelheid;
}




boolean isValidNumber(String input) {
  Serial.println(input);
  boolean isNum = false;
  for (byte i = 0; i < input.length(); i++)
  {
    isNum = isDigit(input.charAt(i)) || input.charAt(i) == '+' || input.charAt(i) == '.' || input.charAt(i) == '-';
    if (!isNum) return false;
  }
  return isNum;
}


void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}

void vooruit(int snelheid)
{
  Serial.print("auto gaat vooruit met snelheid: ");
  Serial.println(snelheid);
 if (snelheid > 123)
  {
    digitalWrite(led1Pin, HIGH);
  } else
  {
    digitalWrite(led1Pin, LOW);
  }
}

void achteruit(int snelheid)
{
  Serial.print("achteruit ");
  Serial.println(snelheid);
   if (snelheid > 123)
  {
    digitalWrite(led2Pin, HIGH);
  } else
  {
    digitalWrite(led2Pin, LOW);
  }

}
