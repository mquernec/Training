public class TotalAndDistinct {
        private  int count = 0;
        protected HashSet<String> set = new ();

        // rely on implicit no-arg constructor

        public void Accumulate(String s) {
          if(!string.IsNullOrEmpty(s))
          {set.Add(s);
          count ++;}
        } 

       public void Combine(TotalAndDistinct other) {
          other.set.ToList().ForEach(s=> set.Add(s));
            count += other.GetTotalCount();
        }

      public  int GetTotalCount() {
            return count;
        }

       public int GetDistinctCount() {
            return set.Count();
        }
    }
