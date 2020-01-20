
unsigned long timer = 0;
float timeStep = 0.01;
const int  buttonPin = 12;

MPU6050 mpu;

unsigned long previousMillis = 0;        // will store last time LED was updated

// constants won't change:
const long interval ; 


void compasssetup()
{
    
  Serial.begin(115200);

  // Initialize MPU6050
  while (!mpu.begin(MPU6050_SCALE_2000DPS, MPU6050_RANGE_2G))
  {
    Serial.println("Could not find a valid MPU6050 sensor, check wiring!");
    delay(500);
  }


  mpu.calibrateGyro();


  mpu.setThreshold(2);
}


float getyaw()  
{
 


  // Output raw


  unsigned long currentMillis = millis();
   if (currentMillis - previousMillis >= (timeStep * 1000) - (millis() - currentMillis)) {
    // save the last time you blinked the LED
    previousMillis = currentMillis;
  Vector norm = mpu.readNormalizeGyro();

  yaw = yaw + norm.ZAxis * timeStep;
  Serial.println(yaw);
   
}
}
