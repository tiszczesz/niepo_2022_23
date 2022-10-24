package com.niepolomice.gridlayout1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class MainActivity : AppCompatActivity() {
    private var player = 1
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        var buttons = arrayOf<Button>(
            findViewById(R.id.btn1),
            findViewById(R.id.btn2),
            findViewById(R.id.btn3),
            findViewById(R.id.btn4),
            findViewById(R.id.btn5),
            findViewById(R.id.btn6),
            findViewById(R.id.btn7),
            findViewById(R.id.btn8),
            findViewById(R.id.btn9),
        )
        for(b in buttons) {
            b.setOnClickListener {
                if (player == 1) {
                    (it as Button).text = "X";
                    player = 2
                } else {
                    (it as Button).text = "O";
                    player = 1
                }
            }
        }
    }
}