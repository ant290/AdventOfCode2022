using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class BackpackProcessor
    {
        List<Backpack>? _backpacks;

        public void ProcessBackpackData(IEnumerable<string> data)
        {
            //clear stored backpacks
            _backpacks = new List<Backpack>();

            //loop through data and generate new backpacks
            Backpack? currentPack = null;
            foreach (string item in data)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    if(currentPack != null) _backpacks.Add(currentPack);
                    currentPack = null;
                    continue;
                }

                currentPack ??= new Backpack();
                currentPack.AddCaloricItem(int.Parse(item));
            }
            if (currentPack != null) _backpacks.Add(currentPack);
        }

        public Backpack? GetFattestPack()
        {
            return _backpacks?.MaxBy(x => x.TotalCalories);
        }

        public IEnumerable<Backpack>? GetPacksBySize()
        {
            return _backpacks?.OrderByDescending(x => x.TotalCalories);
        }
    }

    public class Backpack
    {
        public List<int> MealCalories { get; set; }
        public int TotalCalories => MealCalories.Sum();

        public Backpack()
        {
            MealCalories = new List<int>();
        }

        public void AddCaloricItem(int calories)
        {
            MealCalories.Add(calories);
        }
    }
}
