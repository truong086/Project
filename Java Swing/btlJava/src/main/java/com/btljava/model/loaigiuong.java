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
public class loaigiuong {
    int id;
    String tengiuong;
    int soluong;
    String ngaytao;

    public loaigiuong() {
    }

    public loaigiuong(int id, String tengiuong, int soluong, String ngaytao) {
        this.id = id;
        this.tengiuong = tengiuong;
        this.soluong = soluong;
        this.ngaytao = ngaytao;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTengiuong() {
        return tengiuong;
    }

    public void setTengiuong(String tengiuong) {
        this.tengiuong = tengiuong;
    }

    public int getSoluong() {
        return soluong;
    }

    public void setSoluong(int soluong) {
        this.soluong = soluong;
    }

    public String getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(String ngaytao) {
        this.ngaytao = ngaytao;
    }
    
    
}
