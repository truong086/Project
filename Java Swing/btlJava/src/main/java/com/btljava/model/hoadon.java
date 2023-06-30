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
public class hoadon {
    int id;
    int mabenhnhan;
    String ngayra;
    String phuongphapdieutri;
    String mieuta;
    int thuoc_id;
    int soluong;
    int tongtienthuoc;
    int tongtien;
    String ngaytao;

    public hoadon() {
    }

    public hoadon(int id, int mabenhnhan, String ngayra, String phuongphapdieutri, String mieuta, int thuoc_id, int soluong, int tongtienthuoc, int tongtien, String ngaytao) {
        this.id = id;
        this.mabenhnhan = mabenhnhan;
        this.ngayra = ngayra;
        this.phuongphapdieutri = phuongphapdieutri;
        this.mieuta = mieuta;
        this.thuoc_id = thuoc_id;
        this.soluong = soluong;
        this.tongtienthuoc = tongtienthuoc;
        this.tongtien = tongtien;
        this.ngaytao = ngaytao;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getMabenhnhan() {
        return mabenhnhan;
    }

    public void setMabenhnhan(int mabenhnhan) {
        this.mabenhnhan = mabenhnhan;
    }

    public String getNgayra() {
        return ngayra;
    }

    public void setNgayra(String ngayra) {
        this.ngayra = ngayra;
    }

    public String getPhuongphapdieutri() {
        return phuongphapdieutri;
    }

    public void setPhuongphapdieutri(String phuongphapdieutri) {
        this.phuongphapdieutri = phuongphapdieutri;
    }

    public String getMieuta() {
        return mieuta;
    }

    public void setMieuta(String mieuta) {
        this.mieuta = mieuta;
    }

    public int getThuoc_id() {
        return thuoc_id;
    }

    public void setThuoc_id(int thuoc_id) {
        this.thuoc_id = thuoc_id;
    }

    public int getSoluong() {
        return soluong;
    }

    public void setSoluong(int soluong) {
        this.soluong = soluong;
    }

    public int getTongtienthuoc() {
        return tongtienthuoc;
    }

    public void setTongtienthuoc(int tongtienthuoc) {
        this.tongtienthuoc = tongtienthuoc;
    }

    public int getTongtien() {
        return tongtien;
    }

    public void setTongtien(int tongtien) {
        this.tongtien = tongtien;
    }

    public String getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(String ngaytao) {
        this.ngaytao = ngaytao;
    }
    
    
    
}
