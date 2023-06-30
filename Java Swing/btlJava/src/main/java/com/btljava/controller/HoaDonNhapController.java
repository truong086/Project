/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IHoaDonNhapService;
import com.btljava.Service.Impl.HoaDonNhapService;
import com.btljava.daos.IHoaDonNhap;
import com.btljava.dao.impl.hoadonnhapDao;
import com.btljava.model.hoadonnhap;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class HoaDonNhapController {
    private IHoaDonNhapService dao;
    
    public HoaDonNhapController(){
        dao = new HoaDonNhapService();
    }
    
    
    public boolean insert(hoadonnhap hdn) throws Exception {
        return dao.insert(hdn);
    }

    
    public boolean update(hoadonnhap hdn) throws Exception {
        return dao.update(hdn);
    }

    
    public boolean delete(String hdn) throws Exception {
        return dao.delete(hdn);
    }

    
    public List<hoadonnhap> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<hoadonnhap> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public hoadonnhap findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }
}
