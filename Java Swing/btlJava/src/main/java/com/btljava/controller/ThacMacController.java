/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IThacMacService;
import com.btljava.Service.Impl.ThacMacService;
import com.btljava.daos.IThacMac;
import com.btljava.dao.impl.thacmacDao;
import com.btljava.model.thacmac;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class ThacMacController {
    private IThacMacService dao;
    
    public ThacMacController(){
        dao = new ThacMacService();
    }
    
    public boolean insert(thacmac tm) throws Exception {
        return dao.insert(tm);
    }

    
    public boolean update(thacmac tm) throws Exception {
        return dao.update(tm);
    }

    
    public boolean delete(String tm) throws Exception {
        return dao.delete(tm);
    }

    
    public List<thacmac> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<thacmac> deleteThacMac() throws Exception {
        return dao.deleteThacMac();
    }

    
    public thacmac findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    
    public List<thacmac> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }
}
