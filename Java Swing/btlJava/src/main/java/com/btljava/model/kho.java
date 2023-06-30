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
public class kho {
    int id;
    int sanpham_id;
    int soluong;
    int soluongnhap;
    int daban;
    int tonkho;
    String ngaytao;
    
    int ids;
    String tensanpham;
    int loaisanpham_id;
    String mieuta;
    int giaban;
    String ngaytaos;

    public kho() {
    }

    public kho(int id, int sanpham_id, int soluong, int soluongnhap, int daban, int tonkho, String ngaytao, int ids, String tensanpham, int loaisanpham_id, String mieuta, int giaban, String ngaytaos) {
        this.id = id;
        this.sanpham_id = sanpham_id;
        this.soluong = soluong;
        this.soluongnhap = soluongnhap;
        this.daban = daban;
        this.tonkho = tonkho;
        this.ngaytao = ngaytao;
        this.ids = ids;
        this.tensanpham = tensanpham;
        this.loaisanpham_id = loaisanpham_id;
        this.mieuta = mieuta;
        this.giaban = giaban;
        this.ngaytaos = ngaytaos;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getSanpham_id() {
        return sanpham_id;
    }

    public void setSanpham_id(int sanpham_id) {
        this.sanpham_id = sanpham_id;
    }

    public int getSoluong() {
        return soluong;
    }

    public void setSoluong(int soluong) {
        this.soluong = soluong;
    }

    public int getSoluongnhap() {
        return soluongnhap;
    }

    public void setSoluongnhap(int soluongnhap) {
        this.soluongnhap = soluongnhap;
    }

    public int getDaban() {
        return daban;
    }

    public void setDaban(int daban) {
        this.daban = daban;
    }

    public int getTonkho() {
        return tonkho;
    }

    public void setTonkho(int tonkho) {
        this.tonkho = tonkho;
    }

    public String getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(String ngaytao) {
        this.ngaytao = ngaytao;
    }

    public int getIds() {
        return ids;
    }

    public void setIds(int ids) {
        this.ids = ids;
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

    public String getNgaytaos() {
        return ngaytaos;
    }

    public void setNgaytaos(String ngaytaos) {
        this.ngaytaos = ngaytaos;
    }

    
    
}
