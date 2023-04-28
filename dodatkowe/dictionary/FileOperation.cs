namespace dictionary
{
    class FileOperation
    {
        private readonly string filename;

        public List<string> Content { get; set; }
        public FileOperation(string filename)
        {
            this.filename = filename;
            Content = File.ReadAllLines(filename).ToList();
        }
        public Dictionary<string,int> GetStatistics(){
            var result = new Dictionary<string,int>();
            foreach(var line in Content){
                var words = line.Split(' ');
                foreach(var w in words){
                    var key = w.ToLower().Trim('.').Trim(',');
                    if(result.ContainsKey(key)){
                        result[key] = result[key]+1;
                    }else{
                        result.Add(key,1);
                    }
                }
            }

            return result;
        }
    }
}