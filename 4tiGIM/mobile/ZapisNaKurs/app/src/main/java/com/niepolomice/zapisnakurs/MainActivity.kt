package com.niepolomice.zapisnakurs

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.Spinner
import android.widget.Toast
import com.niepolomice.zapisnakurs.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var bind: ActivityMainBinding;
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        bind = ActivityMainBinding.inflate(layoutInflater);
        setContentView(bind.root)
        val courses = resources.getStringArray(R.array.courses)
        //val spinner = findViewById<Spinner>(R.id.spinnerWybor);
        if(bind.spinnerWybor!=null){
            val adapter = ArrayAdapter(this,android.R.layout.simple_spinner_item,courses)

            bind.spinnerWybor.adapter = adapter
            bind.spinnerWybor.onItemSelectedListener = object :AdapterView.OnItemSelectedListener{
                override fun onItemSelected(p0: AdapterView<*>?, p1: View?, p2: Int, p3: Long) {
                   Toast.makeText(this@MainActivity,"wybrano: ${courses[p2]}",Toast.LENGTH_SHORT).show()
                }
                override fun onNothingSelected(p0: AdapterView<*>?) {

                }
            }
            //val btn = findViewById<Button>(R.id.btnSave);
            bind.btnSave.setOnClickListener {
                bind.tvResult.text = "Zapisano na kurs: ${bind.spinnerWybor.selectedItem.toString()}"
            }


        }


    }
}