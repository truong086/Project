/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.ITienLuongService;
import com.btljava.Service.Impl.TienLuongService;
import com.btljava.daos.Itienluong;
import com.btljava.dao.impl.tienluongDao;
import com.btljava.model.tienluong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class TienLuongController {
    private ITienLuongService dao;
    
    public TienLuongController(){
        dao = new TienLuongService();
    }
    
    
    public boolean insert(tienluong tl) throws Exception {
        return dao.insert(tl);
    }

    
    public boolean update(tienluong tl) throws Exception {
        return dao.update(tl);
    }

    
    public boolean delete(String tl) throws Exception {
        return dao.delete(tl);
    }

    
    public List<tienluong> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<tienluong> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public tienluong findby(String s) throws Exception {
        return dao.findby(s);
    }

    
    public tienluong findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }
}
