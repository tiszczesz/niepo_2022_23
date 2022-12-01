package com.niepolomice.mylayouts_v1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.inputmethod.InputBinding
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import com.niepolomice.mylayouts_v1.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var bind: ActivityMainBinding //viewBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        bind = ActivityMainBinding.inflate(layoutInflater); //viewBinding
        //setContentView(R.layout.activity_main)
        setContentView(bind.root) //viewBinding
//        val editA = findViewById<EditText>(R.id.editTextNumberA);
//        val editB = findViewById<EditText>(R.id.editTextNumberB);
//        val btn = findViewById<Button>(R.id.button);
//        val result = findViewById<TextView>(R.id.textViewResult);
        bind.button.setOnClickListener {
            try{
                val a = bind.editTextNumberA.text.toString().toInt()
                val b = bind.editTextNumberB.text.toString().toInt()
                val nwd = NWD();
                bind.textViewResult.text = nwd.NWDRec(a,b).toString()
            }catch (ex:java.lang.NumberFormatException){
                Toast.makeText(this@MainActivity,"Błędne dane",Toast.LENGTH_SHORT).show()
            }

        }
    }
}