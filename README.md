<img src ='https://github.com/DataJuggler/SharedRepo/blob/master/Python.png' height=128 width=128>

# PythonClassCreator
This C# class is used to create Python classes. Very simple, but saves times creating properties.

This project uses DataJuggler.Win.Controls and DataJuggler.UltimateHelper Nuget packages, and saves me time creating classes for 3D Animation for IClone.

I have a C# Programmer, so please provide me insights if I do anything Python related that is not the correct way.

To run this project, you must have Visual Studio 2022, as it uses .Net 6.0.

Instructions:
Create a 

Here is a sample class that was code generated that includes 4 properties:

class Car:
    def __init__(self):
        self.__Prop = None
        self.__InMotion = False
        self.__StartTime = 0
        self.__EndTime = 0
    def SetProp(self, prop):
        self.__Prop = prop
    def GetProp(self):
        return self.__Prop
    def SetInMotion(self, inMotion):
        self.__InMotion = inMotion
    def GetInMotion(self):
        return self.__InMotion
    def SetStartTime(self, startTime):
        self.__StartTime = startTime
    def GetStartTime(self):
        return self.__StartTime
    def SetEndTime(self, endTime):
        self.__EndTime = endTime
    def GetEndTime(self):
        return self.__EndTime
    Prop=property(GetProp, SetProp)
    InMotion=property(GetInMotion, SetInMotion)
    StartTime=property(GetStartTime, SetStartTime)
    EndTime=property(GetEndTime, SetEndTime)
    


