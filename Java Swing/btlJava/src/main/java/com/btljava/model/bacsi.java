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
public class bacsi {
    int id;
    int manhanvien;
    String hoten;
    String ngaysinh;
    String diachi;
    String email;
    String noicongtac;
    int gioitinh;
    String thanhtich;
    int chucvu_id;
    String ngayvao;

    public bacsi() {
    }

    public bacsi(int id, int manhanvien, String hoten, String ngaysinh, String diachi, String email, String noicongtac, int gioitinh, String thanhtich, int chucvu_id, String ngayvao) {
        this.id = id;
        this.manhanvien = manhanvien;
        this.hoten = hoten;
        this.ngaysinh = ngaysinh;
        this.diachi = diachi;
        this.email = email;
        this.noicongtac = noicongtac;
        this.gioitinh = gioitinh;
        this.thanhtich = thanhtich;
        this.chucvu_id = chucvu_id;
        this.ngayvao = ngayvao;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getManhanvien() {
        return manhanvien;
    }

    public void setManhanvien(int manhanvien) {
        this.manhanvien = manhanvien;
    }

    public String getHoten() {
        return hoten;
    }

    public void setHoten(String hoten) {
        this.hoten = hoten;
    }

    public String getNgaysinh() {
        return ngaysinh;
    }

    public void setNgaysinh(String ngaysinh) {
        this.ngaysinh = ngaysinh;
    }

    public String getDiachi() {
        return diachi;
    }

    public void setDiachi(String diachi) {
        this.diachi = diachi;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getNoicongtac() {
        return noicongtac;
    }

    public void setNoicongtac(String noicongtac) {
        this.noicongtac = noicongtac;
    }

    public int getGioitinh() {
        return gioitinh;
    }

    public void setGioitinh(int gioitinh) {
        this.gioitinh = gioitinh;
    }

    public String getThanhtich() {
        return thanhtich;
    }

    public void setThanhtich(String thanhtich) {
        this.thanhtich = thanhtich;
    }

    public int getChucvu_id() {
        return chucvu_id;
    }

    public void setChucvu_id(int chucvu_id) {
        this.chucvu_id = chucvu_id;
    }

    public String getNgayvao() {
        return ngayvao;
    }

    public void setNgayvao(String ngayvao) {
        this.ngayvao = ngayvao;
    }

    
    
    
}
