namespace WebApplication2 {

    public class BLL {

        public static ConnectionManager DB => new ConnectionManager(@"Server=desktop-k36ebmv\sqlexpress;Database=Test01;Integrated Security=true");

    }
}
