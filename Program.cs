
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

string enjoymentLevel;
enjoymentLevel = GetEnjoymentLevel();
string stadium;
stadium = GetStadiumRecommendation(enjoymentLevel);
string game;
game = GetGameRecommendations(stadium);
string stadiumDetails;
stadiumDetails = DisplayStadiumDetails(stadium, game);



static string GetEnjoymentLevel(){
    System.Console.WriteLine("Do you want to watch a boring, average, fun, or epic football game?");
    string enjoymentLevel = Console.ReadLine();
    return enjoymentLevel;
}


static string GetStadiumRecommendation(string enjoymentLevel){
    string stadium = "";
    if (enjoymentLevel == "boring"){
        stadium = "Neyland Stadium";
    }
    else if (enjoymentLevel == "average"){
        stadium = "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel == "fun"){
        stadium = "Tiger Stadium";
    }
    else if (enjoymentLevel == "epic"){
        stadium = "Saban Field at Bryant-Denny Stadium";
    }
    else{
        stadium = "";
    }
    return stadium;
}

static string GetGameRecommendations(string stadium){
    string game = "";
    if (stadium == "Neyland Stadium"){
        game = "Kent State";
    }
    else if (stadium == "Jordan-Hare Stadium"){
        game = "Kentucky";
    }
    else if (stadium == "Tiger Stadium"){
        game = "Alabama";
    }
    else if (stadium == "Saban Field at Bryant-Denny Stadium"){
        game = "Auburn";
    }
    else{
        game = "";
    }
    return game;
}

static string DisplayStadiumDetails(string stadium, string game){
    if (stadium == ""){
        System.Console.WriteLine($"I cannot determine which game at which stadium you should buy a ticket for");
        string stadiumDetails = "";
        return (stadiumDetails);
    }
    else{
    System.Console.WriteLine($"You should go to {stadium} and watch the {game} game");
    string stadiumDetails = "";
    return (stadiumDetails);}
}