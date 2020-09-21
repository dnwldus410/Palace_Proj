package com.example.ar_map;

import android.app.Application;

import com.mapbox.vision.VisionManager;

public class VisionApp extends Application {
    @Override
    public void onCreate() {
        super.onCreate();
        VisionManager.init(this, getResources().getString(R.string.mapbox_access_token));
    }
}
