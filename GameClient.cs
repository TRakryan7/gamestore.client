using GameStore.Client.Models;

namespace GameStore.Client;
public static class GameClient
{
    private static readonly List<Game> games = new(){
        new Game(){
            Id = 1,
            Name = "Street Figther II",
            Genre = "Figthing",
            Price = 19.99,
            RelaseDate = new DateTime(1992,2,1)
        },
        new Game(){
            Id = 2,
            Name = "Crash Bandicout",
            Genre = "Racing",
            Price = 19.99,
            RelaseDate = new DateTime(1992,2,1)
        },
        new Game(){
            Id = 3,
            Name = "Mortal Combat II",
            Genre = "Figthing",
            Price = 19.99,
            RelaseDate = new DateTime(1992,2,1)
        },
        new Game(){
            Id = 4,
            Name = "Down Hill II",
            Genre = "Bike",
            Price = 19.99,
            RelaseDate = new DateTime(1992,2,1)
        },
        new Game(){
            Id = 5,
            Name = "Street Figther II",
            Genre = "Figthing",
            Price = 19.99,
            RelaseDate = new DateTime(1992,2,1)
        },
    };

    public static Game[] GetGames(){
        return games.ToArray();
    }

    public static void AddGame(Game game){
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    } 

    public static Game GetGame(int id){
        return games.Find(game => game.Id == id) 
        ?? 
        throw new Exception("Could bot find game!");
    }

    public static void UpadteGame(Game update){
        Game existingGame = GetGame(update.Id);
        existingGame.Name = update.Name;
        existingGame.Genre = update.Genre;
        existingGame.Price = update.Price;
        existingGame.RelaseDate = update.RelaseDate;
    }   

    public static void DeleteGame(int id){
        Game game = GetGame(id);
        games.Remove(game);
    } 
}
