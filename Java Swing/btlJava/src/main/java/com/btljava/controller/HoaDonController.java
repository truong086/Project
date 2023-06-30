/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IHoaDonService;
import com.btljava.Service.Impl.HoaDonService;
import com.btljava.daos.IHoaDon;
import com.btljava.dao.impl.hoadonDao;
import com.btljava.model.hoadon;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class HoaDonController {
    private IHoaDonService dao;
    
    public HoaDonController(){
        dao = new HoaDonService();
    }

    
    public boolean insert(hoadon hd) throws Exception {
        return dao.insert(hd);
    }

    
    public boolean update(hoadon hd) throws Exception {
        return dao.update(hd);
    }

    
    public boolean delete(String hd) throws Exception {
        return dao.delete(hd);
    }

    
    public List<hoadon> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<hoadon> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public hoadon findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    
    public List<hoadon> khachhang(String s) throws Exception {
        return dao.khachhang(s);
    }

    
    public List<hoadon> sapxxep() throws Exception {
        return dao.sapxxep();
    }
}
