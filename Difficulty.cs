namespace Devops_CaseStudy_Sohaib
{
    public class Difficulty
    {
        public string level;
        public int lives;

        public Difficulty(string level, int lives)
        {
            this.level = level;
            this.lives = lives;
        }
    }

    public class Easy : Difficulty
    {
        public Easy() : base("Easy", 8)
        {
        }
    }

    public class Medium : Difficulty
    {
        public Medium() : base("Medium", 3)
        {
        }
    }

    public class Hard : Difficulty
    {
        public Hard() : base("Hard", 1)
        {
        }
    }

}