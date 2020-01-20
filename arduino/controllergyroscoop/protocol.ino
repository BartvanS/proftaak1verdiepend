int inputVariable(String input, String what)
{
  Serial.println(commandString);
  if (commandString.equals(what))
  {
    int dblpointIndex = inputString.indexOf(':');
    String snelheidstring = inputString.substring(dblpointIndex + 1);

   
      if (waardeSnelheid() <= 255 && waardeSnelheid() >= 0)
      {
        return waardeSnelheid();
      }
    
  }
}





void getCommand()
{
  if (inputString.length() > 0)
  {

    int beginPoint = inputString.indexOf("#");

    int dblpointIndex = inputString.indexOf(':');
    commandString = inputString.substring(beginPoint + 1, dblpointIndex);



  }
}



int waardeSnelheid()
{
  int dblpointIndex = inputString.indexOf(':');
  int snelheid = inputString.substring(dblpointIndex + 1, inputString.length() - 1).toInt();
  return snelheid;
}




boolean isValidNumber(String input) {

  boolean isNum = false;
  for (byte i = 0; i < input.length(); i++)
  {
    isNum = isDigit(input.charAt(i)) || input.charAt(i) == '+' || input.charAt(i) == '.' || input.charAt(i) == '-';
    if (!isNum) return false;
  }
  return isNum;
}
