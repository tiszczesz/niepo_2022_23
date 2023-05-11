fun main(args: Array<String>) {
    println("Hello World!")
    val content = listOf("ala ma kota","erw rtertert","fggdgdgd d g","gfhfghghfh");
    val fo = FileOperations();
    fo.listToFile("dane.txt",content);
    val dd = fo.fileToList("dane2.txt");
    dd.forEach{ println(it) }
}