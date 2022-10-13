package com.niepolomice.mylinearlayout

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    var licznik = 0 //

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        var btnLike = findViewById<Button>(R.id.btnLike)
        var btnReset = findViewById<Button>(R.id.btnReset)
        var textLike = findViewById<TextView>(R.id.likeNumber)
        var btnSave = findViewById<Button>(R.id.btnSave)
        btnLike.setOnClickListener {
            licznik++
            textLike.text = licznik.toString()+" polubień"
        }
        btnReset.setOnClickListener {
            licznik = if (licznik>0) licznik-1 else licznik
            UpdateLikes(textLike)
        }
        val sharePref = getSharedPreferences("myPref", MODE_PRIVATE);
        val editor = sharePref.edit();
        licznik = sharePref.getInt("licznik",0);
        UpdateLikes(textLike);
        btnSave.setOnClickListener {
            editor.putInt("licznik",licznik);
            editor.apply();
            Toast.makeText(this@MainActivity,"Zapisano",Toast.LENGTH_SHORT).show();
        }
    }
    fun UpdateLikes(view:TextView){
        view.text =  licznik.toString()+" polubień";
    }
}