using System;
using System.Collections.Generic;
using System.Text;

namespace TreeOfTrees
{
    public abstract class Tree
    {
        public string Trunk { get; set; }
        public string Root { get; set; }
        public List<string> Branches { get; set; }

        public abstract string GetSeeds();

        public List<string> GetSeedsMultiple(int times)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < times; i++)
            {
                result.Add(GetSeeds());
            }
            return result;
        }
    }

    public abstract class FriutTree : Tree
    {
        public string FruitName { get; private set; }
        public FriutTree(string fruitName)
        {
            FruitName = fruitName;
        }
    }

    public class AppleTree : FriutTree
    {
        public AppleTree() : base("Apples")
        {

        }

        public override string GetSeeds()
        {
            return FruitName;
        }

    }

}
