using System;
using enginee;
using static System.Runtime.InteropServices.JavaScript.JSType;



Starter hellos = new Starter();
Script play = new Script();

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;


// Scene II - intro
play.say("scene_ii", 1);
play.ask("ask-ii", 1);

play.say("scene_ii", 2, 75);
play.ask("ask-ii", 2);

play.say("scene_ii", 3);
play.ask("ask-ii", 3);

play.say("scene_ii", 4);

hellos.startup();