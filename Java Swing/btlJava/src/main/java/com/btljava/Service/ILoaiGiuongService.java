/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.loaigiuong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface ILoaiGiuongService {
    public boolean insert(loaigiuong lg) throws Exception;
    
    public boolean update(loaigiuong lg) throws Exception;
    
    public boolean delete(String lg) throws Exception;
    
    public List<loaigiuong> findAll() throws Exception;
    
    public loaigiuong findAllid(int id) throws Exception;
    
    public List<loaigiuong> timkiem(String s) throws Exception;
}
