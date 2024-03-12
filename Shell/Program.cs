using PSI;

static class Start {
   static void Main () {
      NProgram? node;
      DirectoryInfo dir = new ("../Shell/Demo/");
      dir.GetFiles ().Select (file => file.FullName).ToList ().ForEach (file => {
         try {
            var text = File.ReadAllText (file);
            node = new Parser (new Tokenizer (text)).Parse ();
            node.Accept (new TypeAnalyze ());
            node.Accept (new PSIPrint ());
            Console.WriteLine ("\n\n// -------------------------------------------\n");
         } catch (ParseException pe) {
            Console.WriteLine ();
            pe.Print ();
         } catch (Exception e) {
            Console.WriteLine ();
            Console.WriteLine (e);
         }
      });
   }
}