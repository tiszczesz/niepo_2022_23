import java.io.File
import kotlin.io.path.Path
import kotlin.io.path.writeLines

class FileOperations {
    public fun fileToList(fileName:String):List<String>{
        return File(fileName).useLines { it.toList() }
    }
    public fun listToFile(fileName: String,content:List<String>){
//        File(fileName).printWriter().use {
//            out -> out.println(content)
//        }
        Path(fileName).writeLines(content);
    }

}