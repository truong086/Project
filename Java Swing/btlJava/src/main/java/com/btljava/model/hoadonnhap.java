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
public class hoadonnhap {
    int id;
    String tensanpham;
    int maloai;
    int gianhap;
    int soliong;
    int makho;
    int nhanvien_id;
    String ngaytao;

    public hoadonnhap() {
    }

    public hoadonnhap(int id, String tensanpham, int maloai, int gianhap, int soliong, int makho, int nhanvien_id, String ngaytao) {
        this.id = id;
        this.tensanpham = tensanpham;
        this.maloai = maloai;
        this.gianhap = gianhap;
        this.soliong = soliong;
        this.makho = makho;
        this.nhanvien_id = nhanvien_id;
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

    public int getMaloai() {
        return maloai;
    }

    public void setMaloai(int maloai) {
        this.maloai = maloai;
    }

    public int getGianhap() {
        return gianhap;
    }

    public void setGianhap(int gianhap) {
        this.gianhap = gianhap;
    }

    public int getSoliong() {
        return soliong;
    }

    public void setSoliong(int soliong) {
        this.soliong = soliong;
    }

    public int getMakho() {
        return makho;
    }

    public void setMakho(int makho) {
        this.makho = makho;
    }

    public int getNhanvien_id() {
        return nhanvien_id;
    }

    public void setNhanvien_id(int nhanvien_id) {
        this.nhanvien_id = nhanvien_id;
    }

    public String getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(String ngaytao) {
        this.ngaytao = ngaytao;
    }
    
    
}
