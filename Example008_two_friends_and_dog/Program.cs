﻿int count = 0;
int distance = 100;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;

while (distance > 10) 
{
    int time = 0;
    if (friend == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.WriteLine("Собака пробежит " + count + " раз.");