package com.niepolomice.mylinearlayout

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    var licznik = 0
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        var btnLike = findViewById<Button>(R.id.btnLike)
        var btnReset = findViewById<Button>(R.id.btnReset)
        var textLike = findViewById<TextView>(R.id.likeNumber)
        btnLike.setOnClickListener {
            licznik++
            textLike.text = licznik.toString()+" polubień"
        }
        btnReset.setOnClickListener {
            licznik = if (licznik>0) licznik-1 else licznik
            textLike.text = licznik.toString()+" polubień"
        }
    }
}