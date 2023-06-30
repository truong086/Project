/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.model;

/**
 *
 * @author ASUS
 */
public class sanpham {
    int id;
    String tensanpham;
    int loaisanpham_id;
    String mieuta;
    int giaban;
    String ngaytao;

    public sanpham() {
    }

    public sanpham(int id, String tensanpham, int loaisanpham_id, String mieuta, int giaban, String ngaytao) {
        this.id = id;
        this.tensanpham = tensanpham;
        this.loaisanpham_id = loaisanpham_id;
        this.mieuta = mieuta;
        this.giaban = giaban;
        this.ngaytao = ngaytao;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTensanpham() {
        return tensanpham;
    }

    public void setTensanpham(String tensanpham) {
        this.tensanpham = tensanpham;
    }

    public int getLoaisanpham_id() {
        return loaisanpham_id;
    }

    public void setLoaisanpham_id(int loaisanpham_id) {
        this.loaisanpham_id = loaisanpham_id;
    }

    public String getMieuta() {
        return mieuta;
    }

    public void setMieuta(String mieuta) {
        this.mieuta = mieuta;
    }

    public int getGiaban() {
        return giaban;
    }

    public void setGiaban(int giaban) {
        this.giaban = giaban;
    }

    public String getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(String ngaytao) {
        this.ngaytao = ngaytao;
    }
    
   
}
