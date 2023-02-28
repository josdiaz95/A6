namespace A6
{
    public class Context
    {
        public List<Movies> Movies { get; set; }

        public  List<Videos>Videos { get; set; }

        public  List<Shows>Shows { get; set; }

        public Context()
        {
           
           Movies = new List<Movies>();
           Movies.Add(new Movies() {Id = 001,Title = "Grown Ups", genres = new string[]{"Family","Comedy"}});
           Movies.Add(new Movies() { Id = 002, Title = "Grown Ups 2", genres = new string[] { "Family", "Comedy"}});
           Movies.Add(new Movies (){ Id = 003, Title = "Daddy's Home", genres = new string[] { "Family", "Comedy" } });


            Videos = new List<Videos>();
            Videos.Add(new Videos(){Id = 004, Title = "CoryxKenshin SSS #3", length  =  2500, regions = new int[]{0,5},format = "Youtube"});
            Videos.Add(new Videos(){ Id = 005, Title = "Roblox 'Dont Call Me a Noob", length = 2540, regions = new int[] { 0, 2 }, format = "Youtube" });
            Videos.Add(new Videos(){ Id = 006, Title = "CoryxKenshin DO NOT WORK AT THIS STORE | Night of the Consumers", length = 1500, regions = new int[] { 0, 5 },format = "Youtube" });
            
            Shows = new List<Shows>();
            Shows.Add(new Shows () {Id = 007, Title = "Stranger  Things", season = 3, episode = 1,writers = new string[]{"Matt Duffer","Ross Duffer"}});
            Shows.Add(new Shows (){ Id = 008, Title = "Stranger  Things", season = 4, episode = 1, writers = new string[] { "Matt Duffer", "Ross Duffer" }});
            Shows.Add(new Shows () { Id = 009, Title = "Stranger  Things", season = 4, episode = 2, writers = new string[] { "Matt Duffer", "Ross Duffer" } });
        }


    }
}
