package com.niepolomice.my_cw2

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val plainText = findViewById<EditText>(R.id.edEditText)
        val button = findViewById<Button>(R.id.button2)
        val textView = findViewById<TextView>(R.id.textView)
        button.setOnClickListener {
            Toast.makeText(this@MainActivity,"ddddddd",Toast.LENGTH_LONG).show()
            textView.text = if (!plainText.text.toString().isEmpty()) plainText.text else " Brak tekstu"
        }
    }
}