package com.niepolomice.first_2022_23_4tig

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.ImageView
import android.widget.Toast
import kotlin.math.log


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val obrazek = findViewById<ImageView>(R.id.imageView1)
        Log.d("TAAAAG",obrazek.toString())
        obrazek.setOnClickListener {
//            Log.d("ffff","fffffffff")
            Toast.makeText(this@MainActivity,"Jestem zebra ",Toast.LENGTH_SHORT).show()
        }

    }
}