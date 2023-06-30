/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.hoadonnhap;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IHoaDonNhapService {
    public boolean insert(hoadonnhap hdn) throws Exception;
    
    public boolean update(hoadonnhap hdn) throws Exception;
    
    public boolean delete(String hdn) throws Exception;
    
    public List<hoadonnhap> findAll() throws Exception;
    
    public List<hoadonnhap> timkiem(String s) throws Exception;
    
    public hoadonnhap findbyid(int s) throws Exception;
}
