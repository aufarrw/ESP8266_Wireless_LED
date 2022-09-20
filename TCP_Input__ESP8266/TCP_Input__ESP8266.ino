#include <ESP8266WiFi.h>
#include <WiFiClient.h>

const char* ssid = "PT. SAS Aero";
const char* pass = "elanghitam";

const char * host = "192.168.56.1"; // your pc ip
String ClientData;
uint16_t dataSensor;
const int ledPin = D1;
const int ledPin2 = D5;

char a;

WiFiServer server(56);
WiFiClient client;

void pinMode_init() {
  pinMode (ledPin, OUTPUT); digitalWrite(ledPin, LOW);
  pinMode (ledPin2, OUTPUT); digitalWrite(ledPin2, LOW);
}

void wifiConnect()
{
      WiFi.begin(ssid, pass);
      Serial.println("");
      while (WiFi.status () != WL_CONNECTED)
      {
        delay(500);
        Serial.print(".");
      }
      Serial.println("");
      Serial.print("Connected to ");
      Serial.println(ssid);
      Serial.print("IP address: ");
      Serial.println(WiFi.localIP());
}

void LED(){
  while(client.available()>0){
    a = client.read();
    ClientData += a;
  }
    if(ClientData == "ON1#"){
      digitalWrite(ledPin, HIGH);
      Serial.println(ClientData);
      client.print("ON1");
    }
    else if(ClientData=="OFF1#"){
      digitalWrite(ledPin, LOW);
      Serial.println(ClientData);
      client.print("OFF1");
    }
    if(ClientData == "ON2#"){
      digitalWrite(ledPin2, HIGH);
      Serial.println(ClientData);
      client.print("ON2");
    }
    else if(ClientData=="OFF2#"){
      digitalWrite(ledPin2, LOW);
      Serial.println(ClientData);
      client.print("OFF2");
    }

    a=0;
    ClientData="";
  }

void setup() {
  Serial.begin(115200);
  wifiConnect();
  server.begin();
  pinMode_init();
  delay(500);
}

void loop() {
   if (WiFi.status() != WL_CONNECTED)
    {
        wifiConnect();
    }   
    client = server.available();

    if (client){

        String data;
        Serial.println("Client connected");
        while (client.connected()){
           while(client.available()>0)
           {
                LED();                
            }
            delay(10);
        }   
  client.stop();
  Serial.println("Client Disconnected");
  }
}
